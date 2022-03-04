namespace FactoryPattern{
    class GeneratePerson{
        public Person create(string a){
            if(a == "giaovien"){
                return new GiaoVien();
            }
            else return new SinhVien();
        }
    }
    class Person{
        
    }
    class SinhVien: Person{}
    class GiaoVien: Person{}

    class App{
        void main(){
            // Hồi đó mình đã if else
            // Tạo sinh viên
            SinhVien s  = new SinhVien();
            // Tạo giáo viên
            GiaoVien a = new GiaoVien();


            GeneratePerson g = new GeneratePerson();
            Person c = g.create("giaovien");
            // => c được tạo là giáo viên luôn, nhiều khi ko cần imple
            // cái constructor nhiều lần
        }
    }
}