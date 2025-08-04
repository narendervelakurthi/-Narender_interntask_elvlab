# Cybersecurity Internship - Task 1

## 🎯 Objective
Scanned my local network for open ports using Nmap to understand which services are exposed and how they might create security risks.

## 🛠 Tools Used
- Nmap (for port scanning)
- Windows Command Prompt
- (Optional) Wireshark

## 📌 Steps Followed

1. Installed Nmap from the official website.
2. Found my IP address using:
   ```
   ipconfig
   ```
   My IP: `192.168.1.100` → Network: `192.168.1.0/24`

3. Ran this Nmap command:
   ```
   nmap -sS 192.168.1.100
   ```

4. Saved output using:
   ```
   nmap -sS 192.168.1.100 -oN scan_results.txt
   ```

5. Took screenshots of the output and saved them as `nmap_output.png`.

6. Identified open ports and analyzed the services running.

---

## 📊 Scan Summary (Scan_results.txt)

| IP Address     | Open Ports             | Services              |
| 192.168.1.100  | 135, 139, 445, 1521, 5560 | msrpc, netbios-ssn, microsoft-ds, oracle, isqlplus |

---

## 🛡️ Risk Analysis (for 192.168.1.100)

- **Port 135 (msrpc)** – Used by Windows services. May be abused for remote code execution if not patched.
- **Port 139 (netbios-ssn)** – Enables file/printer sharing. Can leak file system details.
- **Port 445 (microsoft-ds)** – Major target for ransomware and worms like WannaCry.
- **Port 1521 (oracle)** – Oracle database listener. If unsecured, could allow attackers to access or exploit database services.
- **Port 5560 (isqlplus)** – Oracle's web-based SQL interface. Must be password-protected; otherwise open to attacks.

---

## 📁 Files Included

- `scan_results.txt` — raw Nmap scan output
- `nmap_output.png` — screenshot of command prompt with Nmap scan
- `README.md` — this file

---

## 📚 Key Takeaways

- Learned to use Nmap for network reconnaissance.
- Understood how port scanning reveals network services.
- Identified potential risks from exposed services on my home network.
