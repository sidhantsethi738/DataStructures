public class LinearSearch
{
    //Go through that array till last element
    //Return that index if match found
    //if not return 1
    //0(n)


    public int LSearch( int[] A,int n, int key)
    {
        int index =0;
        while(index < n)
        {
            if(A[index] == key)
                return index;
            else
                index= index+1;
        }
        return -1;
    }
}