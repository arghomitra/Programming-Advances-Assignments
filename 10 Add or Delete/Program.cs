namespace _10_Add_or_Delete
{
    class Program
    {
        static void Main(string[] args)
        {
            BST tree = new BST();

            string input1 = Console.ReadLine();
            if (input1[0] == 'A') AddToTree(tree, input1);
                

            
            
            string input2 = Console.ReadLine();
            //string input3 = Console.ReadLine();


            
        }
        
        static void AddToTree(BST tree,string input1)
        {
            
            string numbers = input1.Substring(1, input1.Length - 1).Trim();
            int[] numb = Array.ConvertAll(numbers.Split(" "), int.Parse);
            foreach (int item in numb)
            {
                tree.Add(item);
            }
            
            tree.TraverseInOrder();
        }
    }
}