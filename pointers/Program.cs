namespace pointers;
public class Program
{
    static void Main(string[] args)
    {
        linkedlist l;
        l = new linkedlist();
        for (int i = 0; i < 10; i++)
        {
            l.addLast(i);
        }
        for (int i =0; i < 10; i++)
        {
            l.addFirst(i);
        }

        Console.WriteLine();

        l.addMiddle(10, 2);
        
        l.affiche();

    }
}
class linkedlist
{
    private class Noeud
    {
        public int valeur;
        public Noeud suiv;

    }
    Noeud? tete;



    public linkedlist()
    {
        tete = null;
    }

    public void addFirst(int x)
    {
        Noeud t = new Noeud();
        t.valeur = x;
        t.suiv = tete;
        tete = t;
    }

    public void affiche()
    {
        Noeud? p = tete;
        while (p != null)
        {
            Console.Write(p.valeur + " => ");
            p = p.suiv;
        }
        Console.Write("null");
    }
    public void addLast(int x)
    {
        if(tete == null)  // 3mlna if le2an barke kenit el list fadye mnel awal fa el add last ma kenit btezbat bala el if
        {
            addFirst(x);
        }
        else
        {
            Noeud t = new Noeud();
            t.valeur = x;
            t.suiv = null;
            Noeud? p = tete;
            while (p.suiv != null)
            {
                p = p.suiv;
            }
            p.suiv = t;
        }
        //zeded comnt tenye
    }
    public void addMiddle(int x, int position)  // ana 3mlta hay w hay w hay
    {
        if (position < 0)
        {
            throw new ArgumentException("Position must be non-negative.");
        }

        if (position == 0)
        {
            addFirst(x);
            return;
        }

        Noeud t = new Noeud();
        t.valeur = x;

        Noeud? p = tete;
        Noeud? previous = null;
        int count = 0;

        while (count < position && p != null)
        {
            previous = p;
            p = p.suiv;
            count++;
        }

        if (count < position)
        {
            throw new ArgumentException("Position is out of bounds.");
        }

        previous.suiv = t;
        t.suiv = p;
    }




}
