using System;
using System.Collections.Generic;
using System.Text;

namespace AppDeConselho.Model
{
    public class Mensagem
    {
        public string Id { get; set; }
        public string Conselho { get; set; }

        public Mensagem()
        {
            this.Id = " ";
            this.Conselho = " ";
        }
    }
}