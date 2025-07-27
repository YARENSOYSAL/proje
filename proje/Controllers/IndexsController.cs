using Microsoft.AspNetCore.Mvc;

namespace proje.Controllers
{
    public class IndexsController : Controller
    {
        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Aciklama(string id)
        {
            var aciklamalar = new Dictionary<string, string>
            {
                {
                    "Balyaj",
@"
<div class='text-center mb-4'>
    <img src='/images/açıklamalar/balyaj1.jpg' class='img-fluid rounded shadow-sm' alt='Balyaj Üst Görseli' />
</div>

<h4>Balyaj</h4>
<p>Saçlarında doğallık isteyenlerin tercih etmesi gereken balyaj, saçların uçlarına doğru yumuşak bir şekilde yapılan boyama işlemini ifade ediyor. Yazın güneşten sararmışçasına bir görünüm isteyenler için devreye giren balyaj farklı renk seçenekleriyle de çeşitlilik kazanıyor.</p>
<p>Mesela sarı balyaj saçlarda daha aydınlık bir görüntü yaratırken, karamel balyaj ise özellikle buğday tenliler ve esmerler için daha uygun.</p>

<div class='row text-center my-4'>
    <div class='col-md-4 mb-3'>
        <img src='/images/açıklamalar/balyaj1.jpg' class='img-fluid rounded shadow-sm' alt='Balyaj Örnek 1' />
    </div>
    <div class='col-md-4 mb-3'>
        <img src='/images/açıklamalar/balyaj1.jpg' class='img-fluid rounded shadow-sm' alt='Balyaj Örnek 2' />
    </div>
    <div class='col-md-4 mb-3'>
        <img src='/images/açıklamalar/balyaj1.jpg' class='img-fluid rounded shadow-sm' alt='Balyaj Örnek 3' />
    </div>
</div>

<h5>Balyaj Çeşitleri Nelerdir?</h5>
<ul>
    <li><strong>Ters balyaj:</strong> Saçın ince tutamlarının açılmasıyla değil, koyulaştırılmasıyla elde edilir.</li>
    <li><strong>Kısmi balyaj:</strong> Saçın her yerine değil, yalnızca ön kısmı gibi, belirli alanlarına uygulanır.</li>
    <li><strong>İnce balyaj:</strong> Saça en doğal şekilde ışıltı ve boyut kazandırır.</li>
</ul>

<h5>Balyajın Avantajları Neler?</h5>
<ul>
    <li>Her ay boyatmanıza gerek kalmaz, genellikle 6 aya kadar dayanır.</li>
    <li>Diplerden gelen saç rahatsız edici durmaz.</li>
    <li>Her saç tipine ve cilt tonuna uyum sağlar.</li>
    <li>Kişiye özgü sonuçlar elde edilir.</li>
</ul>

<h5>Herkes Balyaj Yaptırabilir mi?</h5>
<p>Saçı çok yıpranmış olanların balyajla saçını daha fazla yorması önerilmez. Doğru bakım ile saçlarınız uzun ömürlü sağlıklı kalabilir.</p>

<div class='text-center mt-4'>
    <img src='/images/açıklamalar/balyaj1.jpg' class='img-fluid rounded shadow-sm' alt='Balyaj Alt Görseli' />
</div>
"

                },
                {
                    "Röfle",
                    "<h4>Röfle</h4><p> Röfle, saçlara doğal ve parlak bir görünüm kazandırmak için uygulanan bir renk açma işlemidir. İnce tutamlara yapılan bu uygulama, saça derinlik ve hareket katarak yüz hatlarını daha belirgin gösterir. Genellikle doğal tonlarda yapılır ve saçın genel rengini bozmadan hafif aydınlatma sağlar. Röfle sayesinde saçlar daha canlı ve ışığı yakalayan bir yapıya kavuşur.</p>"
                },
                {
                    "Ombre",
                    "<h4>Ombre</h4><p>Ombre,  saç uçlarına doğru renk geçişi yapılan popüler bir boyama tekniğidir. Saç dipleri genellikle koyu bırakılırken, uçlara doğru kademeli olarak açılır. Bu sayede modern ve şık bir görünüm ortaya çıkar. Ombre, bakımı kolay olması ve saçlara doğal bir güneş etkisi vermesi sebebiyle tercih edilir.</p>"
                },
                {
                    "DipBoyası",
                    "<h4>Dip Boyası</h4><p>Ssaçın uzayan kısmındaki doğal rengin yeniden canlandırılması amacıyla yapılan tazeleme işlemidir. Saç diplerinde oluşan renk açılması veya beyazların kapatılması için uygulanır. Düzenli dip boyası yaptırmak, saç renginin bütünlük kazanmasını ve daha bakımlı görünmesini sağlar.</p>"
                },
                {
                    "TümBoya",
                    "<h4>Tüm Boya</h4><p>Tüm boya işlemi, saçın tamamının tek renk veya tonlarda boyanmasıdır. Saça homojen bir renk vererek, doğal veya cesur renk değişiklikleri yapılabilir. Tüm boya, saçı tamamen kaplamak ve yeni bir görünüm yaratmak için tercih edilir. Boya sonrası saçın parlak ve sağlıklı görünmesi için bakım önerilir.</p>"
                },
                {
                    "OrganikBoya",
                    "<h4>Organik Boya</h4><p>Organik boya, kimyasal içeriklerin minimumda olduğu, doğal bitki özleri ve mineral bazlı formüllerle hazırlanan saç boyası türüdür. Saça zarar verme riski düşüktür ve alerjik reaksiyonlar daha az görülür. Organik boyalar, saçın doğal yapısını koruyarak parlaklık ve canlılık kazandırır, özellikle hassas saç derisine sahip kişiler için idealdir.</p>"
                },
                {
                    "Kesim",
                    "<h4>Kesim</h4><p>Saç kesimi, saçların istenilen boy ve şekle getirilmesi işlemidir. Doğru bir kesim, yüz tipine ve kişisel stile uygun olarak saçın hacmini, hareketini ve görünümünü olumlu yönde etkiler. Saç kesiminde katlı, düz veya modern teknikler kullanılabilir; ayrıca perma ya da renk işlemleriyle kombine edilerek estetik sonuçlar elde edilir.</p>"
                },
                {
                    "Perma",
                    "<h4>Perma</h4><p>Perma, saça dalga veya kıvırcık şekli kazandırmak için uygulanan kimyasal işlemdir. Saç tellerine kalıcı şekil verilerek hacim ve hareketlilik sağlanır. Perma, düz saçlarda doğal bukleler oluşturmak veya saçlara daha dolgun bir görünüm kazandırmak isteyenler için ideal bir seçenektir.</p>"
                },
                {
                    "KrepeBalyaj",
                    "<h4>Krepe Balyaj</h4>saçın belli yerlerine krepe atılarak dışta kalan bolümlerin açıcı yardımıyla renklendirmesine denir<p></p>"
                },
                {
                    "AçmaBoyama",
                    "<h4>Açma Boyama</h4><p>Saçın doğal ya da mevcut koyu rengi, önce açıcı (bleach) maddelerle açılır. Bu işlem saçın pigmentlerini açar, yani saç daha açık bir tona gelir. Saçın istediğin rengi alabilmesi için bu adım önemlidir çünkü koyu saç üzerine doğrudan açık renk boya uygulandığında renk istediğin gibi çıkmayabilir.</p>"
                },
                {
                    "Topuz",
                    "<h4>Topuz</h4><p>Özel günlerde tercih edilen, saçın yukarıdan ya da ense hizasından toplanarak şekil verilmesi işlemidir.</p>"
                },
                {
                    "HareketliTopuz",
                    "<h4>Hareketli Topuz</h4><p>Örgü, gevşek tutamlar ve hacimli formlar kullanılarak yapılan modern topuz şeklidir.</p>"
                }
            };

            if (id != null && aciklamalar.ContainsKey(id))
            {
                ViewBag.Aciklama = aciklamalar[id];
            }
            else
            {
                ViewBag.Aciklama = "<h4>Açıklama bulunamadı</h4>";
            }

            return View();
        }
    }
}