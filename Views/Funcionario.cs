using System;
using Controllers;
using Models;

namespace Views{
    class FuncionarioView
    {
        //Add the employer
        public static void addFunc(int id, String nome, String cpf ){
           FuncionarioController.addFunc(id, nome, cpf);
        }
        //Function for show a employers list 
        public static void getFunc(){
            foreach(FuncionarioModels funcionario in FuncionarioController.getFuncs()){
                Console.WriteLine(funcionario);
            }
        }
    }
}