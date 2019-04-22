using System;
using System.Collections.Generic;
using System.Text;

namespace P08.PetClinic
{
    public class Clinic
    {
        private Dictionary<int, Pet> roomPet;
        private int roomsCount;

        public Clinic(string name, int roomsCount)
        {
            this.Name = name;
            this.RoomsCount = roomsCount;
            this.roomPet = new Dictionary<int, Pet>();
        }

        public string Name { get; set; }

        public int RoomsCount
        {
            get
            {
                return this.roomsCount;
            }
            set
            {
                if (value % 2 == 0)
                {
                    throw new InvalidProgramException("Invalid Operation!");
                }
                this.roomsCount = value;
            }
        }

        public bool AddPet(Pet pet)
        {
            int middle = RoomsCount / 2 + 1;

            for (int i = 1; i < middle; i++)
            {
                if (roomPet.ContainsKey(middle) == false)
                {
                    roomPet.Add(middle, pet);
                    return true;
                }

                if (roomPet.ContainsKey(middle - i) == false)
                {
                    roomPet.Add(middle - i, pet);
                    return true;
                }

                if (roomPet.ContainsKey(middle + i) == false)
                {
                    roomPet.Add(middle + i, pet);
                    return true;
                }
            }

            return false;
        }

        public bool Release()
        {
            int middle = RoomsCount / 2 + 1;

            for (int i = middle; i <= RoomsCount; i++)
            {
                if (roomPet.ContainsKey(i))
                {
                    this.roomPet.Remove(i);
                    return true;
                }
            }

            for (int i = 1; i < middle; i++)
            {
                if (roomPet.ContainsKey(i))
                {
                    this.roomPet.Remove(i);
                    return true;
                }
            }

            return false;

        }

        public bool HasEmptyRooms()
        {
            for (int i = 1; i <= RoomsCount; i++)
            {
                if (roomPet.ContainsKey(i) == false)
                {
                    return true;
                }
            }

            return false;
        }

        public string GetPet(int room)
        {
            if (roomPet.ContainsKey(room))
            {
                return roomPet[room].ToString();
            }
            else
            {
                return "Room empty";
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 1; i <= RoomsCount; i++)
            {
                if (roomPet.ContainsKey(i))
                {
                    sb.AppendLine(roomPet[i].ToString());
                }
                else
                {
                    sb.AppendLine("Room empty");
                }
            }

            return sb.ToString().TrimEnd();
        }
    }
}
