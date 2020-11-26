using CC01;
using CC01.BO;
using CC01.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using CC01.BLL;



namespace CC01.BLL
{
    public class CarteBLO
    {

        
        carteDAL carterepo;
        public CarteBLO(string dbfolder )
        {
            carterepo = new carteDAL(dbfolder);
        }
       public void createcarte(Carte carte)
        {
            carterepo.add(carte);
        }
        public void deletecarte(Carte carte)
        {
            carterepo.remove(carte);
        }
        public IEnumerable<Carte> getallcarte()
        {
            return carterepo.find();
        }
        public IEnumerable<Carte> getbyreference(string reference)
        {
            return carterepo.find(x => x.Matricule==reference);
        }
        public IEnumerable<Carte> getby(Func<Carte, bool> predicate)
        {
            return carterepo.find(predicate);
        }

        public void CARTE(Carte anciencarte, Carte nouveaucarte)
        {
             carterepo.modifier(anciencarte, nouveaucarte);
        }
    }
}
