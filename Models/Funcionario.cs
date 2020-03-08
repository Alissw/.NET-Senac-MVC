using System;
using System.Collections.Generic;

namespace Models{
    class FuncionarioModels
    {
        //Getters and setters
        private int id { get; set;}
        public String nome {get; set;}
        public String cpf {get; set;}
        //List for adding employers
        static List<FuncionarioModels> funcionarios = new List<FuncionarioModels>();      
        //Constructor
        public FuncionarioModels(int id, String nome, String cpf){
            this.id = id;
            this.nome = nome;
            this.cpf = cpf;
            funcionarios.Add(this);
        }
        //Function to return a list of employer
        public static List<FuncionarioModels> getFuncs(){
           return funcionarios;
        }

        public override String ToString(){
            return $"ID: {this.id} - Nome: {this.nome} - CPF {this.cpf}"; 
        }
    }
}