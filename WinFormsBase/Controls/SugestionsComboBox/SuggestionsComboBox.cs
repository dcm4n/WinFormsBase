
namespace WinFormsBase.Controls.SugestionsComboBox
{
    public class SuggestionsComboBox : ComboBox
    {
        public SuggestionsComboBox()
        {
            AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            AutoCompleteSource = AutoCompleteSource.ListItems;
            FormattingEnabled = true;
            //SelectedIndex = -1;
        }

        // Prevent preselection of first item
        protected override void OnBindingContextChanged(EventArgs e)
        {
            SelectedIndex = -1;
            base.OnBindingContextChanged(e);
        }

        // Hide DropDown list. Show only suggestions
        protected override void OnKeyDown(KeyEventArgs e)
        {
            DroppedDown = false;
            base.OnKeyDown(e);        
        }
    }
}
