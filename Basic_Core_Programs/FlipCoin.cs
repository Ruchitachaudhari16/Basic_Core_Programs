namespace Basic_Core_Programs
{
    internal class FlipCoin
    {
        //flip coin and print percentage of Heads and Tail.
        public static void flipCoin()
        {
           
          float coinflip;
            //random function for coinflip
            Random r1 = new Random();
            coinflip = r1.Next();
            
            
            if (r1.Next(2) == 0)
            {
                Console.WriteLine("Coin Flip at Head Side");
            }
            else 
            {
                Console.WriteLine("Coin Flip at Tail Side");
            }
           // int percent = (heads / 10) * 100;
      //Console.WriteLine(percent);
        }

    }
}
