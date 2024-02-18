using usov_402_lr3.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<CalcService>();
builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();

app.MapGet("/", (CalcService calcService) => {
    var resultAdd = calcService.Add(7, 2);
    var resultSubtract = calcService.Subtract(8, 4);
    var resultMultiply = calcService.Multiply(10, 3);
    var resultDivide = calcService.Divide(10, 2);
    return $"7 + 2 is {resultAdd}\n" + 
           $"8 - 4 is {resultSubtract}\n" + 
           $"10 * 3 is {resultMultiply}\n" + 
           $"10 / 2 is {resultDivide}\n";
});

app.Run();
