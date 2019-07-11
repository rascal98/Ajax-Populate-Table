<input type="button" name="name" id="fgonder" class="btn btn-primary" value="Deneme" />
<input type="text" id="id-1" name="name" value="" class="form-control" />
<table id="id-1">
    <tr>
        <th>id</th>
        <th>deger</th>
    </tr>
    <tbody>

    </tbody>
</table>
<script type="text/javascript">
    var degisken;
    $(document).ready(function () {

        $("#fgonder").click(function() {

            var ad = "Ad Soyad";//gönderilecek veri
           

            $.ajax({
                url: '/@dil/Kurumsal/Deneme/',
                data: {
                    ad: ad
                    
                },
                dataType: 'json',
                success: function (data) {
                

                    degisken = JSON.stringify(data);
                    var oku = JSON.parse(degisken);
                    for (var i = 0; i < data.length; i++) {
                        console.log(oku[i].Property2);
                        var markup = "<tr><td>" + oku[i].Property1 + "</td><td>" + oku[i].Property2 + "</td></tr>";
                        $("table tbody").append(markup);
                    
                    }
                    
                    $("#id-1").val(oku.Property2);
                }

            });

        });
    })

</script>


 //AJAX TABLO DOLDURMA SCRİPTİ


 //CONTROLLER KISMI
 public ActionResult Deneme(string ad)
        {
        
            List<Products> sonuc; //Döndürülecek Veri
            return Json(sonuc, JsonRequestBehavior.AllowGet);
        }