package com.company;
import java.util.*;
public class MineSweeper {
    String[][] oyunTablosu;
    String[][] mayinTablosu;
    int mayinAdet, mayınsizBolge;
    int satir, sutun;
    int kullaniciSatir, kullaniciSutun;
    boolean win = true;
    int adimSayar=1;

    public MineSweeper(int satir, int sutun){
        this.satir = satir;
        this.sutun = sutun;
        oyunTablosu = new String[satir][sutun];
        mayinTablosu = new String[satir][sutun];
    }

    public void tabloOlustur(){
        Random rnd = new Random();
        int satirRnd,sutunRnd;
        mayinAdet = (int)(satir*sutun/4);
        for (int i=0;i<oyunTablosu.length;i++){
            for (int j=0; j<oyunTablosu[i].length; j++){
                mayinTablosu[i][j] = "-";
                oyunTablosu[i][j] = "-" ;
            }
        }
        for (int k=0;k<mayinAdet;k++){
            satirRnd=rnd.nextInt(satir);
            sutunRnd = rnd.nextInt(sutun);
            mayinTablosu[satirRnd] [sutunRnd] = "*";
        }
        mayınsizBolge = (satir*sutun) - mayinAdet;
    }

    public void kullaniciGiris(){
        Scanner input =new Scanner(System.in);
        System.out.print("Satır giriniz: ");
        kullaniciSatir =input.nextInt();
        System.out.print("Sutun giriniz: ");
        kullaniciSutun = input.nextInt();
        if (kullaniciSatir>=0 && kullaniciSatir<satir){
            if (kullaniciSutun>=0 && kullaniciSutun<sutun){
                mayinKontrol(kullaniciSatir,kullaniciSutun);
            }
            else {
                System.out.println("============================");
                System.out.println("Hatalı giriş Tekrar giriniz:");
                System.out.println("============================");
                kullaniciGiris();
            }
        }
        else {
            System.out.println("============================");
            System.out.println("Hatalı giriş Tekrar giriniz:");
            System.out.println("============================");
            kullaniciGiris();
        }
    }
    public void mayinKontrol(int x, int y){
        for (int i=0; i<oyunTablosu.length;i++){
            for (int j=0; j<oyunTablosu[i].length;j++){
                if (oyunTablosu[i][j] == oyunTablosu[x][y]){
                    if (mayinTablosu[x][y] == "*"){
                        win = false;
                        break;
                    }
                    else {
                        mayinAdetYaz(x,y);
                    }
                }
            }
        }
        adimSayar++;
        kaybetme(win);
    }

    public void mayinAdetYaz(int x, int y){
        int mayinSayac=0;
        for (int i = -1; i < 2; i++) {
            for (int k = -1; k < 2; k++) {
                try {
                    if (mayinTablosu[x + i][y + k] == "*"){
                        mayinSayac++;
                    }
                } catch (Exception e) {
                }
            }
        }
        oyunTablosu[x][y] = String.valueOf(mayinSayac);
    }

    public  void kaybetme(boolean kazandiMi){
        if (kazandiMi == false){
            System.out.println("=========================");
            System.out.println("Game Over");
        }else if(mayınsizBolge<adimSayar){
            win =false;
            System.out.println("=========================");
            System.out.println("Kazandınız");
        }else {
            win = true;
        }
    }

    public void run(){
        tabloOlustur();
        System.out.println("Mayınların konumu");
        tabloYaz(mayinTablosu);
        System.out.println("================================");
        System.out.println("Mayın Tarlasına hoşgeldiniz");
        while (win){
            tabloYaz(oyunTablosu);
            System.out.println("================================");
            kullaniciGiris();
            System.out.println("================================");
        }
    }

    public void tabloYaz(String[][] str){
        for (String[] satir:str){
            for (String sutun: satir){
                System.out.print(sutun + " ");
            }
            System.out.println(" ");
        }
    }
}
