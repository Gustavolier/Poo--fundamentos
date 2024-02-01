using Balta.SharedConext;

namespace Balta.SubscriptionContext
{
    public class Subscription : Base 
    
    {
         public DateTime? EndDate { get; set; } 
        public Plan Plan { get; set; }

        public bool IsInactive => EndDate <= DateTime.Now;
    }
}
