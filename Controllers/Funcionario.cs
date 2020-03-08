using System;
using System.Collections.Generic;
using Models;

namespace Controllers{
    class FuncionarioController{
        //Function for adding employer in model
        public static void addFunc(int id, string nome, string cpf){
            new FuncionarioModels(id, nome, cpf);
        }
        //Function to return the employer list in the view
        public static List<FuncionarioModels> getFuncs(){
            return FuncionarioModels.getFuncs();
        }
    }
}