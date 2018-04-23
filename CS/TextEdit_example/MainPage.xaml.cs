using System;
using Windows.UI.Xaml.Controls;

namespace TextEdit_example {
    public sealed partial class MainPage : Page {
        public MainPage() {
            this.InitializeComponent();
        }

        private void ButtonInfo_Click(object sender, EventArgs e) {
            textEdit.EditValue = string.Empty;
        }
    }
}
