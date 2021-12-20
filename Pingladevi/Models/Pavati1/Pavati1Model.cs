using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Pingladevi.Data;
using System.IO;

namespace Pingladevi.Models
{
    public class Pavati1Model
    {
        public int Id { get; set; }
        public System.DateTime Date { get; set; }
        public string Name { get; set; }
        public string Mobileno { get; set; }
        public string PaymentInWord { get; set; }
        public string PaymentInNo { get; set; }

        public List<Pavati1Model> GetPavati1List()
        {
            PingladeviEntities Db = new PingladeviEntities();
            List<Pavati1Model> lstPavati1 = new List<Pavati1Model>();
            var AddPavati1List = Db.Tbl_Pavati.ToList();
            if (AddPavati1List != null)
            {
                foreach (var Pavati1 in AddPavati1List)
                {
                    lstPavati1.Add(new Pavati1Model()
                    {
                        Id = Pavati1.Id,
                        Date = Pavati1.Date,
                        Name = Pavati1.Name,
                        Mobileno = Pavati1.Mobileno,
                        PaymentInWord = Pavati1.PaymentInWord,
                        PaymentInNo = Pavati1.PaymentInNo,


                    });
                }
            }
            return lstPavati1;
        }
    
public Pavati1Model EditData(int Id)
{
    string Message = "";
    Pavati1Model model = new Pavati1Model();
    PingladeviEntities Db = new PingladeviEntities();
    var editData = Db.Tbl_Pavati.Where(p => p.Id == Id).FirstOrDefault();
    if (editData != null)
    {
        model.Id = editData.Id;
        model.Date = editData.Date;
        model.Name = editData.Name;
        model.Mobileno = editData.Mobileno;
            model.PaymentInWord = editData.PaymentInWord;
            model.PaymentInNo = editData.PaymentInNo;
        }

    Message = "Record Edited Successfully";
    return model;
} 
 } 
} 
