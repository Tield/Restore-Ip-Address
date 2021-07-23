public class Solution {
    public IList<string> RestoreIpAddresses(string s) {
     IList<string> resp = new List<string>();
        if(s.Length > 12) return resp; 
        Trackear(s,0,new List<string>(),resp);
        return resp;
        
    }
    
    
    private void Trackear(string s, int st, IList<string> li, IList<string> resp){
        if(st==s.Length && li.Count == 4){
            string ip = string.Join(".",li.ToArray());
            resp.Add(ip);
            return;
        }
        for(int l = 1; l<=s.Length-st;++l){
            string car = s.Substring(st,l);
            
            if(Valido(car))
            {
                li.Add(car);
                Trackear(s,st+l,li,resp);
                li.RemoveAt(li.Count-1);
            }   
        }
    }
    
    private bool Valido(string car)
    {
        if(car.Length>3) return false;
        int num = int.Parse(car);
        if(num < 0 || num > 255 || car.Length != num.ToString().Length) return false;
        
        return true;
    }
    
    
}
