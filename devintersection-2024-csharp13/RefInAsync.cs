namespace CSharp13;

public class RefInAsync
{
    public async void M()
    {
        await Task.Delay(1_000);
        ref int x = ref L(); // error previously, now allowed
        x.ToString();
        await Task.Delay(2_000);
        // x.ToString(); // still error

        ref int L() 
            => ref (new int[1])[0];
    }
}
