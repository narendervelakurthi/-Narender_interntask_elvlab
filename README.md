# Network Traffic Analysis with Wireshark - Task 5

## 📋 Project Overview

This project demonstrates packet capture and analysis using **Wireshark**.  
The goal was to capture live network traffic, identify protocols, and analyze packet contents.

**Objective:** Capture live packets, analyze at least 3 different protocols, and summarize findings.

---

## 🛠 Tools Used
- **Wireshark** (Network Protocol Analyzer)
- **Windows OS**
- **Web Browser (Chrome)** for generating traffic
- **Target Website:** testphp.vulnweb.com

---

## 📊 Protocols Identified

### 1. HTTP (Hypertext Transfer Protocol)
- Observed multiple **GET** and **POST** requests.  
- Example:  
  - **POST** request to `/secured/newuser.php` with form data.  
  - Credentials like *username, password, email, phone, etc.* were transmitted **in plaintext**.  
- **Finding:** HTTP is insecure as it exposes sensitive data.

---

### 2. TCP (Transmission Control Protocol)
- Reliable, connection-oriented protocol.  
- Observed **SYN, SYN-ACK, ACK** packets showing **three-way handshake**.  
- Used as the transport layer for HTTP and DNS traffic.  
- Ensures reliability via sequence and acknowledgment numbers.

---

### 3. ARP (Address Resolution Protocol)
- Maps **IP addresses to MAC addresses** within the local network.  
- Observed multiple **Who has / is at** requests and replies.  
- Example: 172.26.218.229 mapping to MAC `4a:66:ab:a7:f9:dd`.  

---

### 4. ICMPv6 (Internet Control Message Protocol v6)
- Used for **network diagnostics and neighbor discovery** in IPv6.  
- Observed **Neighbor Solicitation** and **Neighbor Advertisement** messages.  
- Helps identify active hosts on the same link.

---

### 5. DNS (Domain Name System)
- Translates domain names into IP addresses.  
- Observed multiple queries, including:  
  - `testphp.vulnweb.com` → 44.228.249.3  
  - `google.com`, `safebrowsing.google.com`, etc.  
- Queries and responses captured in clear text.

---

## 🚨 Key Findings
1. **Sensitive data exposure**: Login details captured in plain HTTP traffic.  
2. **Unencrypted traffic**: Both DNS and HTTP requests were visible without encryption.  
3. **Protocol variety**: At least 5 different protocols were identified (HTTP, TCP, ARP, ICMPv6, DNS).  

---

## 📋 Methodology
1. Installed and launched **Wireshark**.  
2. Selected active **Wi-Fi interface**.  
3. Started packet capture and generated traffic by browsing websites.   
4. Applied filters (`http`, `tcp`, `arp`, `icmpv6`, `dns`) to analyze traffic.  
5. Saved capture and extracted findings.  

---


## 🎯 Skills Demonstrated
- Packet Capture & Analysis  
- Protocol Filtering & Identification  
- Security Analysis of Plaintext Traffic  
- Network Troubleshooting  

---

**Conclusion:** This exercise shows how powerful Wireshark is for analyzing network traffic and highlights the risks of unencrypted protocols like HTTP and DNS.
