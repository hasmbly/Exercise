using Exercise.CommonCode.Accurate.InconsistentData.Dto;
using System.Text.Json;

namespace Exercise.CommonCode.Accurate.InconsistentData.SampleCode
{
    public static class InconsistentDataSampleCode
    {
        public static void Run()
        {
            try
            {
                try
                {
                    //var expectedResponse = File.ReadAllText("C:\\Git\\local\\ConsoleApplication\\src\\ConsoleApp\\Accurate\\InconsistentData\\SampleCode\\ExpectedResponse.json");
                    //var expectedResponseToDto = JsonSerializer.Deserialize<SalesInvoiceDto>(expectedResponse);
                    //Console.WriteLine($"expectedResponseToDto: \n{expectedResponseToDto.ToPrettyJson()}");

                    //var actualResponse = File.ReadAllText("C:\\Git\\local\\ConsoleApplication\\src\\ConsoleApp\\Accurate\\InconsistentData\\SampleCode\\ActualResponse.json");
                    var actualResponse = File.ReadAllText("C:\\Git\\local\\ConsoleApplication\\src\\ConsoleApp\\Accurate\\InconsistentData\\SampleCode\\InternalServerError.html");

                    if (actualResponse[0] == '<')
                    {
                        throw new Exception("Ups this reponse was HTML not a Json");
                    }

                    var actualResponseToDto = JsonSerializer.Deserialize<SalesInvoiceDto>(actualResponse);

                    Console.WriteLine($"actualResponseToDto: \n{actualResponseToDto.ToPrettyJson()}");
                }
                catch (Exception exception)
                {
                    Console.WriteLine($"inner try: {exception.Message}");

                    throw;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"outer try: {e.Message}");
            }
        }
    }
}