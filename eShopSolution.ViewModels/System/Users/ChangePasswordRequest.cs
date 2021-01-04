using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.ViewModels.System.Users
{
    public class ChangePasswordRequest
    {
        public Guid Id { get; set; }

        [Display(Name = "Mật khẩu cũ")]
        [DataType(DataType.Password)]
        public string OldPassWord { get; set; }

        [Display(Name = "Mật khẩu mới")]
        [DataType(DataType.Password)]
        public string NewPassWord { get; set; }

        [Display(Name = "Xác nhận mật khẩu")]
        [DataType(DataType.Password)]
        public string ConfirmNewPassWord { get; set; }
    }
}
