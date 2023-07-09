﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;


namespace BanDongHo.Models.Service
{
    public class ContactService
    {
        public static bool SendMail(ViewModel.ContactViewModel model)
        {
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            try
            {
                //ĐỊA CHỈ SMTP Server
                //smtp.Host = "smtp.gmail.com";
                //Cổng SMTP
                smtp.Port = 587;
                //SMTP yêu cầu mã hóa dữ liệu theo SSL
                smtp.EnableSsl = true;
                //UserName và Password của mail
                smtp.Credentials = new NetworkCredential("linhtinh141202@gmail.com", "tuanvu12345");
                String message = "Mail send from " + model.Name + "\n" +
                  "Phone: " + model.Phone + "\n" + model.Content;


                //Tham số lần lượt là địa chỉ người gửi, người nhận, tiêu đề và nội dung thư
                smtp.Send(model.Email, "linhtinh141202@gmail.com", "Contact from " + model.Name, message);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}