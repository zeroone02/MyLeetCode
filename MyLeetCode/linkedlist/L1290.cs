namespace MyLeetCode.linkedlist;
public class L1290
{
    public int GetDecimalValue(ListNode head)
    {
        string str = "";
        while (head != null)
        {
            str += head.val.ToString();
            head = head.next;
        }
        int res = Convert.ToInt32(str, 2);
        return res;
    }
}
