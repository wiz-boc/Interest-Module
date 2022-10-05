-- ----------------------------
-- Table structure for `status_codes`
-- ----------------------------
DROP TABLE IF EXISTS `status_codes`;
CREATE TABLE `status_codes` (
  `status_id` int(11) NOT NULL AUTO_INCREMENT,
  `status_name` varchar(50) NOT NULL,
  PRIMARY KEY (`status_id`)
);

-- ----------------------------
-- Records of status_codes
-- ----------------------------
INSERT INTO `status_codes` VALUES ('1', 'PENDING');
INSERT INTO `status_codes` VALUES ('2', 'ACTIVE');
INSERT INTO `status_codes` VALUES ('3', 'CANCELLED');

-- ----------------------------
-- Table structure for `instruments`
-- ----------------------------
DROP TABLE IF EXISTS `instruments`;
CREATE TABLE `instruments` (
  `ins_code` varchar(20) NOT NULL,
  `description` text NOT NULL,
  `status_id` int(11) DEFAULT NULL,
  PRIMARY KEY (`ins_code`)
);

-- ----------------------------
-- Records of instruments
-- ----------------------------
INSERT INTO `instruments` VALUES ('CLASSIC_REPO', 'Classic Repo','5');
INSERT INTO `instruments` VALUES ('RETAIL_REPO', 'Retail Repo','5');
INSERT INTO `instruments` VALUES ('REV_REPO', 'Reverse Repo','5');
INSERT INTO `instruments` VALUES ('GOJ_BOND', 'Government of Jamaica 9.0% Bond','5');
INSERT INTO `instruments` VALUES ('OM_LOAN', 'Open Market Loan','5');
INSERT INTO `instruments` VALUES ('IGEN', 'Income Generator','5');
INSERT INTO `instruments` VALUES ('SAV_ACC', 'Savings Account','5');



-- ----------------------------
-- Table structure for `interests`
-- ----------------------------
DROP TABLE IF EXISTS `interests`;
CREATE TABLE `interests` (
  `interest_id` int(11) NOT NULL AUTO_INCREMENT,
  `ins_code` varchar(20) DEFAULT NULL,
  `interest_rate` datetime DEFAULT NULL,
  `effective_date` datetime DEFAULT NULL,
  `status_id` int(11) DEFAULT NULL,
  PRIMARY KEY (`interest_id`)
);
