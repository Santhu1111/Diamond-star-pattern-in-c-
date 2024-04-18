using System;
class star_patterns{
    public static void Main(string[] args){
        for(int x=1;x<=10;x++){
            for(int y=10;y>=x;y--){
                Console.Write(" ");
            }
            for(int num=1;num<=x;num++){
                Console.Write("*");
            }
            for(int num=1;num<=x;num++){
                Console.Write("*");
            }
            Console.WriteLine();

            
        }

        for(int x=1;x<=10;x++){
            for(int y=1;x>=y;y++){
                Console.Write(" ");
            }
            for(int num=10;x<=num;num--){
                Console.Write("*");
            }
            for(int num=10;x<=num;num--){
                Console.Write("*");
            }
            Console.WriteLine();
        }
        

        




        
        
    }
}