using EnterpriseMVVM.Windows;
using System.ComponentModel.DataAnnotations;

namespace EnterpriseMVVM.DesktopClient.ViewModels
{
    public class CustomerViewModel : ViewModel
    {
        private string customerName;

        [Required]
        [StringLength(32, MinimumLength = 8)]
        public string CustomerName
        {
            get { return customerName; }
            set
            {
                customerName = value;
                NotifyPropertyChanged();
            }
        }

        // protected override string onValidate(string propertyName)
        // {
        //     if (CustomerName != null && CustomerName.Length < 4)
        //         return "Customer name must be greater than or equal to 4 characters";
        // 
        //     return base.onValidate(propertyName);
        // }
    }
}
