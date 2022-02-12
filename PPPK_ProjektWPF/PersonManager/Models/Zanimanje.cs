namespace Zadatak.Models
{
    public class Zanimanje
    {
        public int IDZanimanje { get; set; }
        public string Naziv { get; set; }

        public override string ToString() => Naziv;
       
    }
}
