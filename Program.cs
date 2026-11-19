namespace Cicaszepsegverseny
{
    internal class Program
    {
        static int[,] cicaErtekelesek;
        static Random r = new Random();

        static string[] Macskanevek(int cicamennyiseg)
        {
            string[] cicak = { "Cirmi", "Mirci", "Picúr", "Bolyhos", "Morzsi", "Pamacs", "Cicó", "Füles", "Tigris", "Mogyoró", "Szotyi", "Pöttyös", "Bajusz", "Gombóc", "Pöttöm", "Csoki", "Vanília", "Fahéj", "Pihe", "Bundás", "Maci", "Zokni", "Papucs", "Kormi", "Hópihe", "Szuszi", "Dorombi", "Nudli", "Galuska", "Pogácsa", "Kifli", "Bukta", "Rétes", "Mákos", "Túró", "Dió", "Paprika", "Lecsó", "Pörkölt", "Kolbász", "Tepertő", "Szalonna", "Uborka", "Bors", "Sáfrány", "Gyömbér", "Málna", "Áfonya", "Szilva", "Barack", "Mandula", "Pisztácia", "Karamell", "Mézi", "Kókusz", "Brownie", "Muffin", "Sushi", "Taco", "Nacho", "Pizza", "Waffle", "Pudding", "Oreo", "Tofu", "Mochi", "Wasabi", "Ramen", "Miso", "Luna", "Csillag", "Holdas", "Üstökös", "Kozmosz", "Neutron", "Kvark", "Pixel", "Bájt", "Bit", "Null", "Bug", "Debug", "Lambda", "Async", "Await", "Linq", "Stack", "Heap", "Pointer", "Mátrix", "Index", "Tömb", "Ciklus", "Változó", "Kekszi", "Herceg", "Hercegnő", "Báró", "Gróf", "Őrnagy", "Kapitány", "Professzor", "Doktor", "Sir Dorombol", "Lord Bajusz", "Méltóságos Úr", "Mancs", "Karmos", "Puha", "Bolyhi", "Szöszi", "Nyávogó", "Dorombos", "Lusta", "Alvó", "Ugrabugra", "Kalamajka", "Káosz", "Rendetlen", "Hurrikán" };




            return cicanevek[];
        }



        static void Main(string[] args)
        {
            Console.WriteLine("Mennyi cica legyen a versenyen? ");
            int cicamennyiseg = Convert.ToInt32(Console.ReadLine());
            string[] cicanevek = Macskanevek(cicamennyiseg);

        }
    }
}
