using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using View;

namespace MVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Inputting an employer
            FuncionarioView.addFunc(1,"Alisson","077.444.236-04");

            //Shows the employers
            FuncionarioView.getFunc();

        }
    }
}