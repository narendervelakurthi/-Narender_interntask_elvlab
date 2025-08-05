# Phishing Email Analysis Report

## 📧 Email Subject:
"Email: wpx@protonmail.com Rectification deactivation"

---

## 🔍 Phishing Indicators:

1. **Spoofed Sender**
   - Email claimed to be from ProtonMail but was sent from `host.com`.

2. **Header Failures**
   - SPF: Fail  
   - DKIM: None  
   - DMARC: Fail  
   - Indicates the email was not verified by the server

3. **Suspicious IP**
   - Sent from `103.167.91.40` (Vietnam), not a known ProtonMail IP

4. **Urgency & Threats**
   - Message says account will be deleted — classic social engineering

5. **Poor Grammar**
   - Subject line and email body contain awkward or robotic phrases

6. **Spam Detection**
   - X-Spam: Yes  
   - Email flagged by server as phishing

---

## 🛠 Tools Used:

- [MXToolbox Email Header Analyzer](https://mxtoolbox.com/EmailHeaders.aspx)  
- [VirusTotal](https://www.virustotal.com/)  
- Text editor to view `.eml` file  

---

## ✅ Conclusion

This is a clear phishing attempt. It failed email validation checks, spoofed the sender, used scare tactics, and lacked personalization. It should be reported and deleted.

