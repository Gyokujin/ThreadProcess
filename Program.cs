internal class Program
{
    static void Main(string[] args)
    {
        Thread thread = new Thread(Print);
        thread.Start();
    }

    static void Print() 
    {
        int count, delayTime;

        Console.Write("출력할 횟수 입력하시오. ");
        count = int.Parse(Console.ReadLine());

        Console.Write("몇 초마다 출력할지 입력하시오. ");
        delayTime = int.Parse(Console.ReadLine()) * 1000;

        for (int i = 0; i < count; i++)
        {
            Console.WriteLine("출력");
            Thread.Sleep(delayTime); // 이때 괄호 안의 숫자는 밀리초를 의미한다 => 0.1초
        }

        Console.WriteLine("쓰레드 종료");
    }
}