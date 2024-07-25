namespace Modelos
{
        public class Almoxarifado
    {
            string Quantidades;
            string EntradadeMateriais;
            string SaidadeMateriais;
            string MateriaisEsgotados;
            string NumerodaOperação;
            int Id;

        public void SetQuantidades (string q)
            {
                Quantidades = q;
            }
        
        public string GetQuantidades ()
            {
                return Quantidades;
            }

        public void SetEntradadeMateriais (string em)
            {
                EntradadeMateriais = em;
            
            }

        public string GetEntradadeMateriais ()
            {
                return EntradadeMateriais;
            }

        public void SetSaidadeMateriais (string sm)
            {
                SaidadeMateriais = sm;
            }

        public string GetSaidadeMaterias ()
            {
                return SaidadeMateriais;
            }

        public void SetmateriaisEsgotados (string me)
            {
                MateriaisEsgtados = me;
            }

        public string GetMateriasEsgostados ()
            {
                return MateriaisEsgotados;
            }

        public void SetNumerodaOperação (string no)
            {
                NumerodaOperação = no;
            }

        public string GetNumerodaOperação ()
            {
                return NumerodaOperação;
            }
    }
}