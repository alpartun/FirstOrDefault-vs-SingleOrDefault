using BenchmarkDotNet.Attributes;

namespace firstordefaultvssingleordefault;

public class BenchmarkLINQPerformance
{
    private readonly List<int> _data = new List<int>();
    private readonly int[] _arr = new int[1000];
    [GlobalSetup]
    public void GlobalSetup()
    {
        for (int i = 0; i < 1000; i++)
        {
            _arr[i] = i;
            _data.Add(i);
        }
    }
    [Benchmark]
    public int Single() => _arr.SingleOrDefault(x=>x==500);
    [Benchmark]
    public int First() => _arr.FirstOrDefault(x=> x==500);
    [Benchmark]
    public int ListSingle() => _data.SingleOrDefault(x=>x==500);
    [Benchmark]
    public int ListFirst() => _data.FirstOrDefault(x=> x==500);
}