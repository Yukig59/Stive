using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stive.Client.Data.Models;
namespace Stive.Client.Data.Methods
{
    public class DataView : DTO_Article
    {
        public DataView() 
        {

            this.Description =  "test n° 5654";
            this.Designation =  "jonémar";
            
        }
    }
}
