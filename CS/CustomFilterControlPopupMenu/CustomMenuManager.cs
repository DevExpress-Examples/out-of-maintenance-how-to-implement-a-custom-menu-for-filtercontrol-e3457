using System;
using System.Drawing;
using DevExpress.XtraBars;
using System.Windows.Forms;
using DevExpress.Utils.Menu;
using DevExpress.XtraEditors;
using System.Collections.Generic;

namespace CustomFilterControlPopupMenu {
    public class CustomMenuManager :IDXMenuManager {
        BarManager Manager;

        public CustomMenuManager(BarManager manager) {
            this.Manager = manager;
        }

        PopupControlContainer fPopup;
        PopupControlContainer Popup {
            get {
                if (fPopup == null) {
                    fPopup = new PopupControlContainer();
                    fPopup.Manager = Manager;
                    fPopup.CloseUp += OnPopupCloseUp;
                }
                return fPopup;
            }
        }

        ListBoxControl fListBox;
        ListBoxControl ListBox {
            get {
                if (fListBox == null) {
                    fListBox = new ListBoxControl();
                    fListBox.Dock = DockStyle.Fill;
                    fListBox.Parent = Popup;
                    fListBox.MouseClick += OnItemClick;
                    fListBox.KeyDown += OnListBoxKeyDown;
                    fListBox.IncrementalSearch = true;
                }
                return fListBox;
            }
        }

        void OnItemClick(object sender, EventArgs e) {
            ((DXMenuItemWrapper)ListBox.SelectedItem).DoClick();
            Popup.HidePopup();
        }

        void OnPopupCloseUp(object sender, EventArgs e) {
            foreach (IDisposable d in ListBox.Items)
                d.Dispose();
            ListBox.Items.Clear();
        }

        void OnListBoxKeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter)
                OnItemClick(fListBox, EventArgs.Empty);
        }

        class DXMenuItemWrapper :IDisposable {
            DXMenuItem Item;

            public DXMenuItemWrapper(DXMenuItem item) {
                this.Item = item;
            }

            public override string ToString() {
                return Item.Caption;
            }

            public void DoClick() {
                Item.GenerateClickEvent();
            }

            #region IDisposable
            void IDisposable.Dispose() {
                Item = null;
                GC.SuppressFinalize(this);
            }
            #endregion
        }

        #region IDXMenuManager
        IDXMenuManager IDXMenuManager.Clone(Form newForm) {
            return this;
        }

        void IDXMenuManager.DisposeManager() {
            fPopup.Dispose();
            Manager = null;
        }

        void IDXMenuManager.ShowPopupMenu(DXPopupMenu menu, Control control, Point pos) {
            if (menu.Tag == null)
                new DXPopupStandardOwnerDrawMenu(new DXMenuItemPainter(), menu).Show(
                    control, pos);
            else {
                ListBox.BeginUpdate();
                try {
                    foreach (DXMenuItem i in menu.Items)
                        ListBox.Items.Add(new DXMenuItemWrapper(i));
                } finally { ListBox.EndUpdate(); }
                Popup.ShowPopup(control.PointToScreen(pos));
                ListBox.Focus();
            }
        }
        #endregion
    }
}
