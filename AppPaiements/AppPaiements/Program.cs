using AppPaiements;

internal class Program
{
    private static void Main(string[] args)
    {
        CarteCredit paiementCC1 = new CarteCredit(1050.50, "Achat de Pc", 345768120);
        CarteCredit paiementCC2 = new CarteCredit(1200.40, "Achat de server", 984761876);
        CarteCredit paiementCC3 = new CarteCredit(345, "Epicerie", 456896333);

        paiementCC1.AfficherDetails();
        paiementCC2.AfficherDetails();
        paiementCC3.AfficherDetails();
    }
}