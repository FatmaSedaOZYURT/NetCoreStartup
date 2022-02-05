# NetCoreExample

<strong>Proje ayağa kalkarken önce Main metodu çalışır.</strong>
Main metodu da Kestrel Web Server'ı ayağa kaldırır.

Startup class ı çalıştırılır.

<h1>Startup.cs</h1>

Startup class ını ise, bir konfigürasyon olarak düşünmek gerekir. Server ile ilgili ayarlamalar ve düzenlemeler buradan yapılır.


<h1>ConfigureServices Metodu</h1>

Projede neye ihtiyaç duyuluyorsa, onun ayarlarının yapıldığı metot.
MVC, API, Cors,.. gibi
DependencyInjection ile ilgili.

<h1>Configure Metodu</h1>

Projede nasıl response döneceğimize bağlı olarak burada düzenleme yapılır. 

<h1>👩‍💻 Yazılımcı hatalarını detaylı almak için</h1>
<code>
 if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
 </code>
<p>Bo kod yazılır.</p>
<br>
<h1>🚀 Controller Tanımlanması</h1>
<p>Controller tanımlanması için, class'ın <b>ControllerBase</b> class ından kalıtım alması gerekir.</p>
<br>
<p>Eğer Controller aracılığıyla servisimizi yöneteceksek, servisimize bunu bildirmemeiz gerekir.</p>
<code>
 public void ConfigureServices(IServiceCollection services)
 {
     services.AddControllers();
 }
</code>
