// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//Scrivere un codice csharp che crea un accumulatore e poi lo utilizza
//Esempio: var accumulatore1 = CreaAccumulatore();
//accumulatore1(10) => 10
//accumulatore1(40) => 50
//accumulatore1(90) => 140
/*
 * In javascript  (closure)
  Maker() {
    let tot = 0;
    return (n) => {
        tot += n;
        return tot;
    }
  }
 * */
//1: per evitare di dichiarare un tipo cosa uso? var!!!
var Maker = () =>
{
    long totale = 0;
    return (int n) =>
    {
        totale += n;
        return totale;
    };
};
var acc1 = Maker();
var acc2 = Maker();
Console.WriteLine(acc1(10));
Console.WriteLine(acc1(10));
Console.WriteLine(acc1(10));
Console.WriteLine(acc2(10));
Console.WriteLine(acc2(10));
Console.WriteLine(acc2(10));


Console.WriteLine("--------------------------------------------------");
//Data una lista di interi , metterli tutti al quadrato

List<int> list = new List<int>() {1,2,3,4,5,6,7};
List<int> lquadrato = Quadrato(list);

List<int> Quadrato(List<int> list)
{
    List<int> result = new List<int>();
    foreach (int num in list)
    {
         int sum = num * num;
         result.Add(sum);
    }
    return result;
}

foreach (int n in lquadrato)
{
    Console.WriteLine(n);
}

Console.WriteLine("--------------------------------------------------");
//Ora realizzare un metodo che esegue l'evento al cubo
List<int> lcubo = Cubo(list);

foreach(int n in lcubo)
{
    Console.WriteLine(n);
}

List<int> Cubo(List<int> list)
{

    List<int> result = new List<int>();
    foreach (int num in list)
    {
        int sum = num * num * num;
        result.Add(sum);
    }
    return result;

}

Console.WriteLine("--------------------------------------------------");

List<int> EseguiIlCalcolo(List<int> list, Func<int, int> fun)
{
    List<int> lout = new List<int>();
    foreach (int n in list)
        lout.Add(fun(n));
    return lout;
}
List<int> lcalcolo = EseguiIlCalcolo(list, (n) => n * (n + 1) / 2);


foreach (int n in lcalcolo)
    Console.WriteLine(n);
//Abbiamo in questo modo costruito una funzione "generale" per trasformare
//tutti gli elementi di una stringa da numero intero a numero intero => nuovo = f(vecchio);
//Purtroppo per come è stata costruita, questa funzione si applica esclusivamente alle lista di numeri interi 
//e torna una lista di numeri interi

Console.WriteLine("--------------------------------------------------");

//se invece avessi voluto data una lista di stringhe , ottenere una lista delle loro lunghezze
List<string> ls = new List<string>() { "uno", "due", "tre", "quattro", "dieci" };

//inuscita vottei avere una lista id interi
//{3,3,3,7,5};

//NON posso usare la EseguiCalcolo poichè in ingresso stavolta c'è una lista di stringhe 
List<int> EseguiIlCalcoloS(List<string> list, Func<string, int> fun)
{
    List<int> lout = new List<int>();
    foreach (string n in list)
        lout.Add(fun(n));
    return lout;
}

var lslen = ls.Select(l => l.Length);   
foreach (int n in lslen)
{
    Console.WriteLine(n);
}

Console.WriteLine("--------------------------------------------------");


var listaQuadrati = list.Select(n => n * n);
foreach (int n in listaQuadrati)
{
    Console.WriteLine(n);
}

Console.WriteLine("--------------------------------------------------");

//data una lista di interi estrarre la lista che contiene tutti i pari

//formulazione
List<int> EstraiPari(List<int> list)
{
    List<int> listapari = new List<int>();
    foreach(int i in list)
        if((i%2)==0)
            listapari.Add(i);
    return listapari;
}

List<int> listapari = EstraiPari(list);
foreach (int n in listapari)
{
    Console.WriteLine(n);
}
Console.WriteLine("--------------------------------------------------");
//formulazione 1
var lpari = list.Where(n => n % 2 == 0); 
//fanno la stessa cosa .Qual'è la migliore??
foreach(int n in lpari)
{
    Console.WriteLine(n);
}


Console.WriteLine("--------------------------------------------------");

//ordinare una lista di interi
list = new List<int> { 9 , 11 , 2 , 4 ,3 ,2 , 7};
list.Sort();
list.Reverse(); //al contrario
foreach(int n in list)
{
    Console.WriteLine(n);
}

Console.WriteLine("--------------------------------------------------");
//ordinato
//per farlo disordinato invertire i valori di return
list = new List<int> { 9, 11, 2, 4, 3, 2, 7  , 22 , 10 ,55 ,82};
list.Sort((int v1 ,int v2) =>
{
    if (v1 < v2)
        return -1;
    if (v1 == v2)
        return 0;
    else return 1;
});

foreach(int n in list)
{
    Console.WriteLine(n);
}

Console.WriteLine("--------------------------------------------------");

//Data la lista di stringhe {"uno", "due", "tre", "quattro", "cinque", "Sei"}
//ordinarla in modo alfabetico e stamparla in verso decrescente

//Formulazione 1
List<string> lstr = new List<string>() { "uno", "due", "tre", "quattro", "cinque", "Sei" };
//Con gli insiemi ordinati
SortedSet<string> ords = new SortedSet<string>();
foreach (String s in lstr)
    ords.Add(s);
foreach (String s in ords)
    Console.WriteLine(s);

Console.WriteLine("--------------------------------------------------");
//formulazione 2
List<string> stringhe = new List<string>() { "uno", "due", "tre", "quattro", "cinque" ,"sei" };
stringhe.Sort();
stringhe.Reverse();

foreach (string s in stringhe)
{
    Console.WriteLine(s);
}

Console.WriteLine("--------------------------------------------------");

//formulazione 3
stringhe = new List<string>() { "uno", "due", "tre", "quattro", "cinque", "sei" };
stringhe.Sort((string s1, string s2) => -s1.CompareTo(s2));
foreach(string s in stringhe)
{
    Console.WriteLine(s);
}


Console.WriteLine("--------------------------------------------------");
//Esercizio finale
//Data una lista di coppie <string,int> , stamparle ordinate
//rispetto alla stringa
//una coppia in csharp ssi dichiara come
// Tuple<string,int> quindi una lista  di coppie sarà
List<Tuple<string, int>> lcoppie = new List<Tuple<string, int>>()
{
    new Tuple <string,int>("uno",1),
    new Tuple <string,int>("due",2),
    new Tuple <string,int>("quattro",4),
    new Tuple <string,int>("sette",7),
    new Tuple <string,int>("diciannove",19),
};

lcoppie.Sort(Comparer<Tuple<string, int>>.Default);

foreach(Tuple<string, int> s in lcoppie)
{
    Console.WriteLine (s);  
}

Console.WriteLine("--------------------------------------------------");

