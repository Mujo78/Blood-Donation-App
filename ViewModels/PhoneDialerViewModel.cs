using DarujKrv.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DarujKrv.ViewModels
{
    public class PhoneDialerViewModel
    {
        private string phoneNumber;
        public Command CalleNumberCommand { get; } 

        public string PhoneNumber
        {
            get => phoneNumber; 
            set => phoneNumber = value; 
        }

        public PhoneDialerViewModel()
        {
            CalleNumberCommand = new Command(OnCallNumber);
        }

        void OnCallNumber()
        {
			Davaoci_KrviServices.CallNumberPhone(PhoneNumber);
        }
    }
}
