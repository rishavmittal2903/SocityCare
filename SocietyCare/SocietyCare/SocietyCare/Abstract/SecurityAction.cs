namespace SocietyCare.Abstract
{
    public abstract class SecurityAction
    {
        public abstract void AskForPermission(string flatId);
        public abstract void DisplayFlatDetails(string societyId);
    }
}
