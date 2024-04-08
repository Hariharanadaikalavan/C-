public class arrayex{
public void equal()
 {
     int[] firstarray = { 2, 3, 4, 5 };
     int[] secondarray = { 2, 3, 4, 5 };
     bool result = firstarray.SequenceEqual(secondarray); 
     Console.WriteLine(result);
 }

public static void main(String args[]){
  arrayex obj=new arrayex();
  obj.equal();
}
}
