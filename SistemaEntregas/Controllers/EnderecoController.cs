using Modelos;
using System.Collections.Generic;
using System.Linq;



namespace Controllers
{
    public class EnderecoController
    {

        static List<Endereco> Enderecos = new List<Endereco>();
        static int ultimoID = 0;

        public void SalvarEndereco(Endereco endereco )
        {
            int id = ultimoID + 1;
            ultimoID = id;

            endereco.EnderecoID = id;
            Enderecos.Add(endereco);
        }

        public Endereco PesquisarPorID(int idEndereco)
        {
            var c = from x in Enderecos
                    where x.EnderecoID.Equals(idEndereco)
                    select x;

            if (c != null)
                return c.FirstOrDefault();
            else
                return null;
        }
    }
}
