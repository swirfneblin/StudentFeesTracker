namespace StudentFeesTracker.Factories;
public class LateStudentFeeFactory : StudentFeeFactory
{
    public override decimal CalculateFeeAmount(decimal amount)
    {
        return amount * 1.1m;
    }
}