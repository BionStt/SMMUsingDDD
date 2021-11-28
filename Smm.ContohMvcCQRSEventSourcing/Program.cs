using Smm.ContohMvcCQRSEventSourcing.BackgroundServices;
using Smm.ContohMvcCQRSEventSourcing.DDD.EventDomain;
using Smm.ContohMvcCQRSEventSourcing.DDD.Events;
using Smm.ContohMvcCQRSEventSourcing.Persistence;
using Smm.ContohMvcCQRSEventSourcing.Persistence.Event;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddContohCQRSESDbContext(builder.Configuration.GetConnectionString("LeasingRazorConnection"));



// Infrastructure - Data EventSourcing
builder.Services.AddScoped<IStoredEvents, StoredEvents>();
builder.Services.AddSingleton<IEventSerializer, EventSerializer>();

// Messaging
builder.Services.AddScoped<IMessagePublisher, MessagePublisher>();
builder.Services.AddScoped<IMessageProcessor, MessageProcessor>();

// Message processing
var section = builder.Configuration.GetSection(nameof(MessageProcessorServiceOptions));
var messageProcessorTaskOptions = section.Get<MessageProcessorServiceOptions>();
builder.Services.AddSingleton(messageProcessorTaskOptions);
builder.Services.AddHostedService<MessagesProcessorService>();


// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
