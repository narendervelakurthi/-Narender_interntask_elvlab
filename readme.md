# UFW Firewall Configuration - Task 4🛡️🔥🧱 

## 📋 Project Overview
**Objective:** Configure and test firewall rules using UFW to block Telnet (port 23) and allow SSH (port 22).    
**System:** Kali Linux  
**Target IP:** 10.167.116.229

---

## 🛠️ Implementation Steps

### 1. Enable UFW and Configure Defaults
Commands executed:
```bash
sudo ufw enable
sudo systemctl enable ufw
sudo ufw logging on
sudo ufw default deny incoming
sudo ufw default allow outgoing
```

### 2. Block Telnet (Port 23) and Allow SSH (Port 22)
Commands executed:
```bash
sudo ufw deny 23/tcp
sudo ufw deny 23/udp
sudo ufw allow ssh
```
These rules deny Telnet connections while preserving SSH access.

### 3. Testing the Firewall Rules
- Checked listening ports: `sudo netstat -tlnp`
- From remote system:  
```bash
nmap -p 23 10.167.116.229
```
Result: **Port 23 filtered (blocked)**.  

### 4. Final Firewall Status
Checked with:
```bash
sudo ufw status verbose
```
Output showed port 23 denied, port 22 allowed, default deny for incoming.  

---

## 📊 Security Impact Assessment
- **Risk Eliminated:** Telnet access disabled (no unencrypted login possible).  
- **Administrative Access:** SSH allowed for secure management.  
- **Default Policy:** Deny incoming connections reduces attack surface.  

---

## 📋 Conclusion
The UFW firewall was successfully configured to improve security on Kali Linux.  
- ✅ Telnet (port 23) connections blocked.  
- ✅ SSH (port 22) access preserved.  
- ✅ Default deny incoming and allow outgoing rules applied.  
- ✅ Testing validated firewall effectiveness.

---
