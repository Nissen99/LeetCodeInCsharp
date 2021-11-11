namespace FirstBadVersion278
{
    public class Solution
    {
        public int BadVersion { get; set; }
        
        public int FirstBadVersion(int n)
        {
            int low = 0;
            int high = n;

            while (low <= high)
            {
                int mid = low + ((high - low) / 2);

                
                if (IsBadVersion(mid) && !IsBadVersion(mid-1))
                {
                    return mid;
                } else if (IsBadVersion(mid))
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }

            return -1;
        }
        
        
        /*
         * In the problem a method called "isBadVersion" is given, just using this for syntax
         */
        public bool IsBadVersion(int verstion)
        {
            return verstion >= BadVersion;
        }
    }
}