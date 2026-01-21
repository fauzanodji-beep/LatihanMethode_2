int jumlahitem, hargaitme;

decimal diskon, totalbayar;


decimal hitungdiskon(int jml_item)
{
    if (jml_item == 50)
        return 50000;
    else if (jml_item == 10)
        return 72000;
    else
        return 0;
}

decimal hitungtotalbayar(int jml_item, int harga_item, decimal diskon)
{
    return jml_item * harga_item - diskon;
}

Console.WriteLine("Masukkan jumlah item: ");
jumlahitem = int.Parse(Console.ReadLine());

Console.WriteLine("Masukan harga item: ");
hargaitme = int.Parse(Console.ReadLine());

diskon = hitungdiskon(jumlahitem);

totalbayar = hitungtotalbayar(jumlahitem, hargaitme, diskon);

Console.WriteLine($"Total bayar: Rp {totalbayar}");