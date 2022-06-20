Console.WriteLine("Reversing a Number");
int n = 50, calrem,mulvar,addrem,divnum;
for(int i = 1; i < n; i++)
{
    calrem = n % i;
    mulvar = calrem * 10;
    addrem = calrem + mulvar;
    divnum = addrem / 10;
    Console.WriteLine(divnum);
}