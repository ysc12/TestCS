using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test6
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}

/*

iLifeEntity <- 인터페이스
LifeEntity(iLifeEntity를 상속받음) <- 클래스
MainCharactor, Monster <- 클래스(LifeEntity를 상속받음)
Zombie (Monster 상속받음)
Ghost(Monster 상속받음)

iLifeEntity 내용엔 공격(함수), 데미지받음(함수)가 있음
LifeEntity는 체력(int), 공격력(int)과 공격, 데미지 받음을 재정의함
MainCharactor와 Monster는 LifeEntity를 상속 받음
데미지를 줄때는 해당 클래스의 데미지받음을 호출함
 
 
 
 */