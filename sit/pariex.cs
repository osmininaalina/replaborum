     private int GetParentProcess(int Id)
     {
         int parentPid = 0;
         using (ManagementObject mo = new ManagementObject("win32_process.handle='" + Id.ToString() + "'"))
         {
             mo.Get();
             parentPid = Convert.ToInt32(mo["ParentProcessId"]);
         }
         return parentPid;
     }
     