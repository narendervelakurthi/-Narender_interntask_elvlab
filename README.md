# Basic Vulnerability Scan - Task 3

## 📌 Objective
Perform a vulnerability scan on my PC using Nessus Essentials, identify security issues, and document findings with remediation steps.

---

## 🛠 Tools Used
- **Nessus Essentials** (Free edition from Tenable)
- **Operating System:** Windows

---

## 🔍 Steps Followed
1. **Installed Vulnerability Scanner**
   - Downloaded Nessus Essentials from [Tenable](https://www.tenable.com/products/nessus/nessus-essentials)
   - Activated using a free license key (Nessus).

2. **Configured Scan Target**
   - Found local IP using `ipconfig` (Windows).
   - Set my PC's IP address as the target in the scanner.

3. **Ran Full Vulnerability Scan**
   - Duration: ~40–60 minutes.
   - Avoided interrupting the scan.

4. **Reviewed Results**
   - Checked vulnerabilities by severity: Critical, High, Medium, Low, Info.

5. **Researched Fixes**
   - Searched CVEs and vendor recommendations for remediation.

6. **Documented Findings**
   - Took screenshots and recorded top vulnerabilities with fixes.

---


## 🔍 Scan Summary
| Severity  | Count |
|-----------|-------|
| **Critical** | 1 |
| **High**     | 1 |
| **Medium**   | 4 |
| **Low**      | 0 |
| **Info**     | 43 |

---

## ⚠ Key Findings & Fixes

### 1️⃣ Critical – Outdated Software Component
- **Description:** Nessus detected a software package that is outdated and has known critical security vulnerabilities.
- **Risk:** Could allow remote code execution if exploited.
- **Fix:**
  - Update the affected software to the latest vendor-released version.
  - Check vendor security advisories for relevant patches.

---

### 2️⃣ High – SMB Signing Disabled
- **Description:** SMB protocol signing is not enforced, allowing man-in-the-middle (MITM) attacks.
- **Risk:** An attacker could intercept SMB traffic and modify data.
- **Fix:**
  - Enable SMB signing in Windows Group Policy:
    - Run `gpedit.msc`
    - Navigate to: **Computer Configuration → Windows Settings → Security Settings → Local Policies → Security Options**
    - Enable **"Microsoft network server: Digitally sign communications (always)"**.

---

### 3️⃣ Medium – Weak TLS Configuration
- **Description:** System supports outdated TLS versions (TLS 1.0/1.1).
- **Risk:** Vulnerable to downgrade attacks.
- **Fix:**
  - Disable TLS 1.0/1.1 in system or web server settings.
  - Ensure TLS 1.2 or TLS 1.3 is enforced.

---

### 4️⃣ Medium – Outdated OpenSSL Library
- **Description:** OpenSSL version is outdated and may allow attackers to execute code remotely.
- **Risk:** High exploitation probability.
- **Fix:** Update OpenSSL to the latest stable release from the official vendor.

---

### 5️⃣ Medium – Insecure Services Enabled
- **Description:** Certain legacy or unnecessary services are running.
- **Risk:** May be exploited for privilege escalation or lateral movement.
- **Fix:** Disable unused services via **Services.msc** or PowerShell.

---

## 📚 Learning Outcomes

Through this project, the following cybersecurity competencies were demonstrated:

1. **Vulnerability Assessment**: Practical experience with industry-standard scanning tools.
2. **Risk Analysis**: Ability to categorize and prioritize security findings.
3. **Remediation Planning**: Development of actionable security improvement strategies.
4. **Documentation**: Professional security assessment reporting.
5. **Tool Proficiency**: Hands-on experience with Nessus Essentials.
