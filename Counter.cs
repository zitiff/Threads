using System;

public class Counter
{
    private int value; 
    public Counter(int startValue = 0)
    {
        value = startValue;
    }
    
    public void Increment()
    {
        value++;
    }
    
    public int GetValue()
    {
        return value;
    }
}

