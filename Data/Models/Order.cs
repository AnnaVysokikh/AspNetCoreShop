using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace itprogershop.Data.Models;

public class Order {
    [BindNever]
    public int id { set; get; }
    [Display(Name = "Введите имя")]
    [StringLength(25)]
    [Required(ErrorMessage = "Длина имени не менее 5 символов")]
    public string name { set; get; }
    [Display(Name = "Введите фамилию")]
    [StringLength(25)]
    [Required(ErrorMessage = "Длина фимилии не менее 5 символов")]
    public string surname { set; get; }
    [Display(Name = "Введите адрес")]
    [StringLength(55)]
    [Required(ErrorMessage = "Длина адреса не менее 5 символов")]
    public string adress { set; get; }
    [Display(Name = "Введите телефон")]
    [DataType(DataType.PhoneNumber)]
    [StringLength(15)]
    [Required(ErrorMessage = "Длина телефона не менее 11 знаков")]
    public string phone { set; get; }
    [Display(Name = "Введите email")]
    [DataType(DataType.EmailAddress)]
    [StringLength(25)]
    [Required(ErrorMessage = "Длина email не менее 15 символов")]
    public string email { set; get; }
    [BindNever]
    [ScaffoldColumn(false)]
    public DateTime orderTime { set; get; }
    [ValidateNever]
    public List<OrderDetail> orderDetails { set; get; }

}