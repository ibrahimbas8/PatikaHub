package com.company;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
	    //mesafe
        //yaş
        //yolculuk tipi
        double perKm=0.1, total,sale,result;
        int km,yas,yolculukTipi;
        Scanner input = new Scanner(System.in);

        System.out.print("KM giriniz : ");
        km = input.nextInt();

        System.out.print("Yas giriniz : ");
        yas = input.nextInt();

        System.out.print("1- Tek Yön 2- Gidiş Dönüş : ");
        yolculukTipi = input.nextInt();

        if (((km>0) && (yas>0))&&(yolculukTipi == 1 || yolculukTipi ==2)){
            total = km * perKm;
            if (yas <=12){
                sale = total * 0.5;
                result = total-sale;
            }
            else if (yas <= 24){
                sale = total * 0.1;
                result = total-sale;
            }
            else if(yas>= 65){
                sale = total * 0.3;
                result = total-sale;
            }
            else {
                result = total;
            }
            if (yolculukTipi == 2){
                sale = result * 0.2;
                result = result - sale;
                result = result * 2;
            }
            System.out.println("Uçak bilet fiyatı : " + result);
        }
        else{
            System.out.println("Hatalı veri girişi yaptınız...");
        }

    }
}
