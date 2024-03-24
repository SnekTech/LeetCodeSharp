namespace Interview150._380;

public class RandomizedSet
{
    private IList<int> nums = new List<int>();
    private Dictionary<int, int> indices = new();
    private Random random = new();

    public bool Insert(int val)
    {
        if (indices.ContainsKey(val))
        {
            return false;
        }

        int index = nums.Count;
        nums.Add(val);
        indices.Add(val, index);
        return true;
    }

    public bool Remove(int val)
    {
        if (!indices.ContainsKey(val))
        {
            return false;
        }

        int index = indices[val];
        int last = nums.Last();
        nums[index] = last;
        indices[last] = index;
        nums.RemoveAt(nums.Count - 1);
        indices.Remove(val);
        return true;
    }

    public int GetRandom()
    {
        int randomIndex = random.Next(nums.Count);
        return nums[randomIndex];
    }
}