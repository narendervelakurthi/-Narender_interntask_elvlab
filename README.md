# Phishing Email Analysis Report

## 📧 Email Subject:
"Email: wpx@protonmail.com Rectification deactivation"

---

## 🔍 Phishing Indicators:

1. **Spoofed Sender**
   - The sender claims to be "protonmail.com" but the real address is "noreply@host.com".

2. **Header Failures (via MxToolbox)**
   - SPF: **Fail** – the sender IP `103.167.91.40` is not authorized to send for `host.com`.
   - DKIM: **None** – no digital signature found, which should normally confirm sender integrity.
   - DMARC: **Fail** – no domain alignment or policy protection detected.
   - ARC: **None** – no signed authentication chain, which weakens email trust.
   - X-Spam: **Yes** – the spam filter flagged the email as a phishing attempt.
   - Country of IP: **Vietnam** – IP belongs to ASN 63737, outside ProtonMail’s infrastructure.

3. **Urgency & Threats**
   - Threatens that "Account will be automatically deleted if not confirmed"

4. **Suspicious Language**
   - Subject line is unnatural: "Rectification deactivation"
   - Message contains robotic, non-personalized warnings.

5. **Suspicious Link**
   - Contains fake confirmation link. (Verified from VirusTotal Tool)

---

## 🛠 Header Breakdown

**Authentication-Results:**  
- SPF: `fail`  
- DKIM: `none`  
- DMARC: `fail`  
- ARC: `none`

**X-Spamd-Result Score:**  
- Total Score: 18.41 / 25.00  
- Flags: SPAMHAUS_ZEN, VIOLATED_DIRECT_SPF, RDNS_NONE, MIME_HTML_ONLY  
- IP: 103.167.91.40 → ASN: 63737 → Country: Vietnam

**Received-From:**  
`host.com (unknown [103.167.91.40]) by mailin025.protonmail.ch`

---

## 🛠 Tools Used:

- [MXToolbox Email Header Analyzer](https://mxtoolbox.com/EmailHeaders.aspx)  
- VirusTotal  
- Manual header inspection

---

## ✅ Conclusion

This email fails all standard security checks. The sender is spoofed, authentication headers fail, and the message uses scare tactics. This is a phishing email and should be reported immediately.
