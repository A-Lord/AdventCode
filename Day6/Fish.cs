namespace AdventCode_main.Day6
{
    public class Fish
    {
        private sbyte _age;


        
        public Fish()
        {
            _age = 8;        
        }

        public Fish(int age)
        {
            _age = Convert.ToSByte(age);
            
            
        }
        public bool AgeUp()
        {

            if(_age == 0)
            {
                _age = 6;
                return true;
            }
            else
            {
                _age--;
                return false;
            }
        }
    }
}